<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushBadgeRequest extends Model
{
    /**
     * @description 微应用agentId
     *
     * @var string
     */
    public $agentId;

    /**
     * @description 推送类型
     *
     * @var string
     */
    public $pushType;

    /**
     * @description 推送的内容（目前仅限数字）
     *
     * @var string
     */
    public $pushValue;

    /**
     * @description 员工userId列表
     *
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'agentId'    => 'agentId',
        'pushType'   => 'pushType',
        'pushValue'  => 'pushValue',
        'userIdList' => 'userIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->pushType) {
            $res['pushType'] = $this->pushType;
        }
        if (null !== $this->pushValue) {
            $res['pushValue'] = $this->pushValue;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushBadgeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['pushType'])) {
            $model->pushType = $map['pushType'];
        }
        if (isset($map['pushValue'])) {
            $model->pushValue = $map['pushValue'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
