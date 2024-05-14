<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCheckInSchemaTemplateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example water_mark_checkin
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description This parameter is required.
     *
     * @example 1234567
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example water_mark_checkin
     *
     * @var string
     */
    public $sceneCode;

    /**
     * @description This parameter is required.
     *
     * @example manage123
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
