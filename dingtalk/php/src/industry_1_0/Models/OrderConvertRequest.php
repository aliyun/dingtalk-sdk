<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\OrderConvertRequest\attachments;
use AlibabaCloud\Tea\Model;

class OrderConvertRequest extends Model
{
    /**
     * @var attachments[]
     */
    public $attachments;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operateUserId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $ruleBizId;
    protected $_name = [
        'attachments' => 'attachments',
        'operateUserId' => 'operateUserId',
        'ruleBizId' => 'ruleBizId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachments) {
            $res['attachments'] = [];
            if (null !== $this->attachments && \is_array($this->attachments)) {
                $n = 0;
                foreach ($this->attachments as $item) {
                    $res['attachments'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operateUserId) {
            $res['operateUserId'] = $this->operateUserId;
        }
        if (null !== $this->ruleBizId) {
            $res['ruleBizId'] = $this->ruleBizId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OrderConvertRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachments'])) {
            if (!empty($map['attachments'])) {
                $model->attachments = [];
                $n = 0;
                foreach ($map['attachments'] as $item) {
                    $model->attachments[$n++] = null !== $item ? attachments::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operateUserId'])) {
            $model->operateUserId = $map['operateUserId'];
        }
        if (isset($map['ruleBizId'])) {
            $model->ruleBizId = $map['ruleBizId'];
        }

        return $model;
    }
}
