<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupSetRequest extends Model
{
    /**
     * @description openTeamId
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description dingIsvOrgId
     *
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @description dingOrgId
     *
     * @var int
     */
    public $dingOrgId;

    /**
     * @description dingSuiteKey
     *
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @description dingTokenGrantType
     *
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @description groupSetName
     *
     * @var string
     */
    public $groupSetName;

    /**
     * @var string
     */
    public $groupTemplateId;
    protected $_name = [
        'openTeamId'         => 'openTeamId',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingOrgId'          => 'dingOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'groupSetName'       => 'groupSetName',
        'groupTemplateId'    => 'groupTemplateId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->groupSetName) {
            $res['groupSetName'] = $this->groupSetName;
        }
        if (null !== $this->groupTemplateId) {
            $res['groupTemplateId'] = $this->groupTemplateId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateGroupSetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['groupSetName'])) {
            $model->groupSetName = $map['groupSetName'];
        }
        if (isset($map['groupTemplateId'])) {
            $model->groupTemplateId = $map['groupTemplateId'];
        }

        return $model;
    }
}
