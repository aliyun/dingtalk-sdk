<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreStoreInfoRequest extends Model
{
    /**
     * @description 门店通通讯录Code
     *
     * @var string
     */
    public $code;

    /**
     * @description 门店Id
     *
     * @var int
     */
    public $storeId;
    protected $_name = [
        'code'    => 'code',
        'storeId' => 'storeId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->storeId) {
            $res['storeId'] = $this->storeId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreStoreInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['storeId'])) {
            $model->storeId = $map['storeId'];
        }

        return $model;
    }
}
