<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest;

use AlibabaCloud\Tea\Model;

class wifis extends Model
{
    /**
     * @description mac地址。
     *
     * @var string
     */
    public $macAddr;

    /**
     * @description wifi的ssid。
     *
     * @var string
     */
    public $ssid;
    protected $_name = [
        'macAddr' => 'macAddr',
        'ssid'    => 'ssid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->macAddr) {
            $res['macAddr'] = $this->macAddr;
        }
        if (null !== $this->ssid) {
            $res['ssid'] = $this->ssid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return wifis
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['macAddr'])) {
            $model->macAddr = $map['macAddr'];
        }
        if (isset($map['ssid'])) {
            $model->ssid = $map['ssid'];
        }

        return $model;
    }
}
