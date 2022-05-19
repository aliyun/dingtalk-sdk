<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateResidentInfoRequest extends Model
{
    /**
     * @description 小区地址
     *
     * @var string
     */
    public $address;

    /**
     * @description 小区类型1纯住宅；2:商住混合；3:办公；4:办公商业混合；5:商业；6:公共场所；7:其他
     *
     * @var int
     */
    public $communityType;

    /**
     * @description 小区名
     *
     * @var string
     */
    public $name;

    /**
     * @description 小区状态：0正常/1关闭/2作废
     *
     * @var int
     */
    public $state;
    protected $_name = [
        'address'       => 'address',
        'communityType' => 'communityType',
        'name'          => 'name',
        'state'         => 'state',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->communityType) {
            $res['communityType'] = $this->communityType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateResidentInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['communityType'])) {
            $model->communityType = $map['communityType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }

        return $model;
    }
}
