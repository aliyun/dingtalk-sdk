<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInstancesByIdsRequest extends Model
{
    /**
     * @description 表单CODE
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 开放数据实例ID集合
     *
     * @var string[]
     */
    public $openDataInstanceIdList;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'formCode'               => 'formCode',
        'openDataInstanceIdList' => 'openDataInstanceIdList',
        'openTeamId'             => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->openDataInstanceIdList) {
            $res['openDataInstanceIdList'] = $this->openDataInstanceIdList;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInstancesByIdsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['openDataInstanceIdList'])) {
            if (!empty($map['openDataInstanceIdList'])) {
                $model->openDataInstanceIdList = $map['openDataInstanceIdList'];
            }
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
