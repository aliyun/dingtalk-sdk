<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo\address;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo\email;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo\link;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo\telephone;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo\workPhone;
use AlibabaCloud\Tea\Model;

class cardContactInfo extends Model
{
    /**
     * @var address[]
     */
    public $address;

    /**
     * @var email[]
     */
    public $email;

    /**
     * @var link[]
     */
    public $link;

    /**
     * @var telephone[]
     */
    public $telephone;

    /**
     * @var workPhone[]
     */
    public $workPhone;
    protected $_name = [
        'address' => 'address',
        'email' => 'email',
        'link' => 'link',
        'telephone' => 'telephone',
        'workPhone' => 'workPhone',
    ];

    public function validate() {}

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
        if (null !== $this->link) {
            $res['link'] = [];
            if (null !== $this->link && \is_array($this->link)) {
                $n = 0;
                foreach ($this->link as $item) {
                    $res['link'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (null !== $this->workPhone) {
            $res['workPhone'] = [];
            if (null !== $this->workPhone && \is_array($this->workPhone)) {
                $n = 0;
                foreach ($this->workPhone as $item) {
                    $res['workPhone'][$n++] = null !== $item ? $item->toMap() : $item;
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
                $n = 0;
                foreach ($map['address'] as $item) {
                    $model->address[$n++] = null !== $item ? address::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['email'])) {
            if (!empty($map['email'])) {
                $model->email = [];
                $n = 0;
                foreach ($map['email'] as $item) {
                    $model->email[$n++] = null !== $item ? email::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['link'])) {
            if (!empty($map['link'])) {
                $model->link = [];
                $n = 0;
                foreach ($map['link'] as $item) {
                    $model->link[$n++] = null !== $item ? link::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['telephone'])) {
            if (!empty($map['telephone'])) {
                $model->telephone = [];
                $n = 0;
                foreach ($map['telephone'] as $item) {
                    $model->telephone[$n++] = null !== $item ? telephone::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['workPhone'])) {
            if (!empty($map['workPhone'])) {
                $model->workPhone = [];
                $n = 0;
                foreach ($map['workPhone'] as $item) {
                    $model->workPhone[$n++] = null !== $item ? workPhone::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
