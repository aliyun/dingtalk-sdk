<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetFamilySchoolConversationsResponseBody;

use AlibabaCloud\Tea\Model;

class groupInfoList extends Model
{
    /**
     * @example corp123
     *
     * @var string
     */
    public $corpId;

    /**
     * @var string[]
     */
    public $deptNameChain;

    /**
     * @example 小王的家校群
     *
     * @var string
     */
    public $groupName;

    /**
     * @example 2
     *
     * @var string
     */
    public $groupType;

    /**
     * @var int
     */
    public $joinGroupTime;

    /**
     * @example cidxxx
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'corpId' => 'corpId',
        'deptNameChain' => 'deptNameChain',
        'groupName' => 'groupName',
        'groupType' => 'groupType',
        'joinGroupTime' => 'joinGroupTime',
        'openConversationId' => 'openConversationId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deptNameChain) {
            $res['deptNameChain'] = $this->deptNameChain;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
        }
        if (null !== $this->joinGroupTime) {
            $res['joinGroupTime'] = $this->joinGroupTime;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deptNameChain'])) {
            if (!empty($map['deptNameChain'])) {
                $model->deptNameChain = $map['deptNameChain'];
            }
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }
        if (isset($map['joinGroupTime'])) {
            $model->joinGroupTime = $map['joinGroupTime'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
