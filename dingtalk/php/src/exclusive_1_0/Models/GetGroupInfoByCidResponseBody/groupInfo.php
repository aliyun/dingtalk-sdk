<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupInfoByCidResponseBody;

use AlibabaCloud\Tea\Model;

class groupInfo extends Model
{
    /**
     * @var bool
     */
    public $allOrgMember;

    /**
     * @var string
     */
    public $groupName;

    /**
     * @var int
     */
    public $groupNumber;

    /**
     * @var string
     */
    public $groupOrganization;

    /**
     * @var string
     */
    public $joinGroupUrl;

    /**
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'allOrgMember' => 'allOrgMember',
        'groupName' => 'groupName',
        'groupNumber' => 'groupNumber',
        'groupOrganization' => 'groupOrganization',
        'joinGroupUrl' => 'joinGroupUrl',
        'openConversationId' => 'openConversationId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->allOrgMember) {
            $res['allOrgMember'] = $this->allOrgMember;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->groupNumber) {
            $res['groupNumber'] = $this->groupNumber;
        }
        if (null !== $this->groupOrganization) {
            $res['groupOrganization'] = $this->groupOrganization;
        }
        if (null !== $this->joinGroupUrl) {
            $res['joinGroupUrl'] = $this->joinGroupUrl;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allOrgMember'])) {
            $model->allOrgMember = $map['allOrgMember'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['groupNumber'])) {
            $model->groupNumber = $map['groupNumber'];
        }
        if (isset($map['groupOrganization'])) {
            $model->groupOrganization = $map['groupOrganization'];
        }
        if (isset($map['joinGroupUrl'])) {
            $model->joinGroupUrl = $map['joinGroupUrl'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
