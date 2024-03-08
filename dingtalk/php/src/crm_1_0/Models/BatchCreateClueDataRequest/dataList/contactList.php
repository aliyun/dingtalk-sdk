<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchCreateClueDataRequest\dataList;

use AlibabaCloud\Tea\Model;

class contactList extends Model
{
    /**
     * @var string
     */
    public $mobile;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $phone;

    /**
     * @var string
     */
    public $qq;

    /**
     * @var string
     */
    public $wangWang;

    /**
     * @var string
     */
    public $weChat;
    protected $_name = [
        'mobile'   => 'mobile',
        'name'     => 'name',
        'phone'    => 'phone',
        'qq'       => 'qq',
        'wangWang' => 'wangWang',
        'weChat'   => 'weChat',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->phone) {
            $res['phone'] = $this->phone;
        }
        if (null !== $this->qq) {
            $res['qq'] = $this->qq;
        }
        if (null !== $this->wangWang) {
            $res['wangWang'] = $this->wangWang;
        }
        if (null !== $this->weChat) {
            $res['weChat'] = $this->weChat;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return contactList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['phone'])) {
            $model->phone = $map['phone'];
        }
        if (isset($map['qq'])) {
            $model->qq = $map['qq'];
        }
        if (isset($map['wangWang'])) {
            $model->wangWang = $map['wangWang'];
        }
        if (isset($map['weChat'])) {
            $model->weChat = $map['weChat'];
        }

        return $model;
    }
}
