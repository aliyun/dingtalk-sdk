<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo\address;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo\email;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo\telephone;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo\wechat;
use AlibabaCloud\Tea\Model;

class cardContactInfo extends Model
{
    /**
     * @description 地址
     *
     * @var address[]
     */
    public $address;

    /**
     * @description 邮箱
     *
     * @var email[]
     */
    public $email;

    /**
     * @description 电话
     *
     * @var telephone[]
     */
    public $telephone;

    /**
     * @description 微信
     *
     * @var wechat[]
     */
    public $wechat;
    protected $_name = [
        'address'   => 'address',
        'email'     => 'email',
        'telephone' => 'telephone',
        'wechat'    => 'wechat',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = [];
            if (null !== $this->address && \is_array($this->address)) {
                $n = 0;
                foreach ($this->address as $item) {
                    $res['address'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->email) {
            $res['email'] = [];
            if (null !== $this->email && \is_array($this->email)) {
                $n = 0;
                foreach ($this->email as $item) {
                    $res['email'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->telephone) {
            $res['telephone'] = [];
            if (null !== $this->telephone && \is_array($this->telephone)) {
                $n = 0;
                foreach ($this->telephone as $item) {
                    $res['telephone'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->wechat) {
            $res['wechat'] = [];
            if (null !== $this->wechat && \is_array($this->wechat)) {
                $n = 0;
                foreach ($this->wechat as $item) {
                    $res['wechat'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cardContactInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            if (!empty($map['address'])) {
                $model->address = [];
                $n              = 0;
                foreach ($map['address'] as $item) {
                    $model->address[$n++] = null !== $item ? address::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['email'])) {
            if (!empty($map['email'])) {
                $model->email = [];
                $n            = 0;
                foreach ($map['email'] as $item) {
                    $model->email[$n++] = null !== $item ? email::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['telephone'])) {
            if (!empty($map['telephone'])) {
                $model->telephone = [];
                $n                = 0;
                foreach ($map['telephone'] as $item) {
                    $model->telephone[$n++] = null !== $item ? telephone::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['wechat'])) {
            if (!empty($map['wechat'])) {
                $model->wechat = [];
                $n             = 0;
                foreach ($map['wechat'] as $item) {
                    $model->wechat[$n++] = null !== $item ? wechat::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
