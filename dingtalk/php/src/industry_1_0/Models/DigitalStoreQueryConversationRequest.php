<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreQueryConversationRequest extends Model
{
    /**
     * @example F1342222
     *
     * @var string
     */
    public $storeCode;
    protected $_name = [
        'storeCode' => 'storeCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->storeCode) {
            $res['storeCode'] = $this->storeCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreQueryConversationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['storeCode'])) {
            $model->storeCode = $map['storeCode'];
        }

        return $model;
    }
}
