<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class IsvMetadataQueryRequest extends Model
{
    /**
     * @example abc
     *
     * @var string
     */
    public $objectCode;
    protected $_name = [
        'objectCode' => 'objectCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->objectCode) {
            $res['objectCode'] = $this->objectCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IsvMetadataQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['objectCode'])) {
            $model->objectCode = $map['objectCode'];
        }

        return $model;
    }
}
