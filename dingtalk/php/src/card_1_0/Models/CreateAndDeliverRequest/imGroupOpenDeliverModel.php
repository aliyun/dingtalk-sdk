<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest;

use AlibabaCloud\Tea\Model;

class imGroupOpenDeliverModel extends Model
{
    /**
     * @var string[]
     */
    public $atUserIds;

    /**
     * @var string[]
     */
    public $recipients;

    /**
     * @example dingg3xmqdkpaojuakm8
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'atUserIds'  => 'atUserIds',
        'recipients' => 'recipients',
        'robotCode'  => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atUserIds) {
            $res['atUserIds'] = $this->atUserIds;
        }
        if (null !== $this->recipients) {
            $res['recipients'] = $this->recipients;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return imGroupOpenDeliverModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atUserIds'])) {
            $model->atUserIds = $map['atUserIds'];
        }
        if (isset($map['recipients'])) {
            if (!empty($map['recipients'])) {
                $model->recipients = $map['recipients'];
            }
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
