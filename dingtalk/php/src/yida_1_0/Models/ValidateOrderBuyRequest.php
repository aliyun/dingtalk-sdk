<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ValidateOrderBuyRequest extends Model
{
    /**
     * @var string
     */
    public $accessKey;

    /**
     * @var string
     */
    public $callerUid;
    protected $_name = [
        'accessKey' => 'accessKey',
        'callerUid' => 'callerUid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accessKey) {
            $res['accessKey'] = $this->accessKey;
        }
        if (null !== $this->callerUid) {
            $res['callerUid'] = $this->callerUid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ValidateOrderBuyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessKey'])) {
            $model->accessKey = $map['accessKey'];
        }
        if (isset($map['callerUid'])) {
            $model->callerUid = $map['callerUid'];
        }

        return $model;
    }
}
