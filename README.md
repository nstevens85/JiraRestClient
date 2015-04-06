 JiraRestClient
================

#### A simple client for Atlassian JIRA service REST API

Available on NuGet as [TechTalk.JiraRestClient](http://nuget.org/packages/TechTalk.JiraRestClient/)

## Capabilities
1. List or enumerate issues of a project
2. Create, load and delete issues
3. Update some issue fields
    - summary
    - description
    - labels
    - original estimate
    - custom fields ('customfield_&lt;id&gt;')
+ Query and apply state transitions
+ List the watchers of an issue
+ List, create and delete comments
+ List, create and delete attachments
+ List, create and delete issue links
+ List, create, update and delete issue remote links
+ List issue types
+ Query server info

--------------------------------------------------

### Version History

**1.0.0**
initial version

**1.0.1**
removed dependency on Newtonsoft.Json

**1.0.2**
fixed the bug introduced in 1.0.1

**1.0.3**
fields set to null are not updated

**1.0.4**
list issues of a given type within a project

**1.0.5**
exceptions contain more information

**1.0.6**
support for issue state transitions

**1.0.7**
support for issue remote links (attached URLs)

**1.0.8**
support for custom issue fields ('customfield_&lt;id&gt;')

**2.1.0**
support for reading actors per issue

**2.2.0**
support for querying issue types and server info

**2.3.0**
ability to enumerate through issues of a project
 
**2.4.0**

- made the JiraClient thread safe
- JQL exposed to the client interface via the `GetIssuesByQuery` method

**2.4.1**
use internal property JiraIdentifier on LoadIssue and UpdateIssue

**2.4.2**
- Expose function to get the browsable link for issue
- Add support to get list of versions associated with project
- Add function to get list of projects on JIRA instance
- Add function to get list of available 'Statuses' and their category's on JIRA instance
- Add function to get list of Change Long entries for issue
- Add function to run generic JQL search and allow specification of 'field' list to be return
- Add field 'remainingEstimate' to the TimeTracking json parse object
- Add 'created' and 'resolution' to IssueFields