<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataSaveRequest\body;

use AlibabaCloud\Tea\Model;

class scope extends Model
{
    /**
     * @example performance
     *
     * @var string
     */
    public $scopeCode;

    /**
     * @example 1
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'scopeCode' => 'scopeCode',
        'version'   => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->scopeCode) {
            $res['scopeCode'] = $this->scopeCode;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return scope
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['scopeCode'])) {
            $model->scopeCode = $map['scopeCode'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
