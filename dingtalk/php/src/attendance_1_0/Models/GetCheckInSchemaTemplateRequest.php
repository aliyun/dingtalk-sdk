<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCheckInSchemaTemplateRequest extends Model
{
    /**
     * @description 业务码：
     * - water_mark_checkin 水印签到
     *
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 群会话ID。
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 场景码：
     * - water_mark_checkin_h3yun 开放场景码
     *
     *
     * @var string
     */
    public $sceneCode;

    /**
     * @description 用户的userid。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizCode'            => 'bizCode',
        'openConversationId' => 'openConversationId',
        'sceneCode'          => 'sceneCode',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->sceneCode) {
            $res['sceneCode'] = $this->sceneCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCheckInSchemaTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['sceneCode'])) {
            $model->sceneCode = $map['sceneCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
