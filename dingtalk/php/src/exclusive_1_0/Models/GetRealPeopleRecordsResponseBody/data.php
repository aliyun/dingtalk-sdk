<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRealPeopleRecordsResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description agentId
     *
     * @var int
     */
    public $agentId;

    /**
     * @description 接口调用时间(毫秒时间戳)
     *
     * @var int
     */
    public $invokeTime;

    /**
     * @description 实人认证结果 1-成功 2-失败
     *
     * @var int
     */
    public $personIdentification;

    /**
     * @description 平台 0-Android 或 1-iOS
     *
     * @var int
     */
    public $platform;

    /**
     * @description 1. 姓名匹配阶段失败 2. 认证阶段失败 3. 实人流程阶段失败 4. 协议签署阶段失败 5. 人脸录入阶段失败 6. 人脸录入阶段用户主动取消 7. 人脸录入阶段成功 8. 人脸识别阶段失败 9. 人脸识别阶段主动取消 10. 人脸识别阶段成功  11.去实人场景
     *
     * @var int
     */
    public $scene;

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'agentId'              => 'agentId',
        'invokeTime'           => 'invokeTime',
        'personIdentification' => 'personIdentification',
        'platform'             => 'platform',
        'scene'                => 'scene',
        'userId'               => 'userId',
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
        if (null !== $this->invokeTime) {
            $res['invokeTime'] = $this->invokeTime;
        }
        if (null !== $this->personIdentification) {
            $res['personIdentification'] = $this->personIdentification;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['invokeTime'])) {
            $model->invokeTime = $map['invokeTime'];
        }
        if (isset($map['personIdentification'])) {
            $model->personIdentification = $map['personIdentification'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
