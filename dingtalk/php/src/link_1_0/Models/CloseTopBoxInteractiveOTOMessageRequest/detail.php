<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\CloseTopBoxInteractiveOTOMessageRequest;

use AlibabaCloud\Tea\Model;

class detail extends Model
{
    /**
     * @description 唯一标识一张卡片的ID，卡片幂等ID
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @description 卡片模板 ID
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @description 用户 userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'cardBizId'      => 'cardBizId',
        'cardTemplateId' => 'cardTemplateId',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardBizId) {
            $res['cardBizId'] = $this->cardBizId;
        }
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return detail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardBizId'])) {
            $model->cardBizId = $map['cardBizId'];
        }
        if (isset($map['cardTemplateId'])) {
            $model->cardTemplateId = $map['cardTemplateId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
