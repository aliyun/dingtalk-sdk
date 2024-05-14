<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserCredentialsResponseBody\content;

use AlibabaCloud\Tea\Model;

class credentialList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 医生资格证书
     *
     * @var string
     */
    public $credentialName;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $credentialType;

    /**
     * @description This parameter is required.
     *
     * @example 2022-08-01
     *
     * @var string
     */
    public $termOfValidity;
    protected $_name = [
        'credentialName' => 'credentialName',
        'credentialType' => 'credentialType',
        'termOfValidity' => 'termOfValidity',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->credentialName) {
            $res['credentialName'] = $this->credentialName;
        }
        if (null !== $this->credentialType) {
            $res['credentialType'] = $this->credentialType;
        }
        if (null !== $this->termOfValidity) {
            $res['termOfValidity'] = $this->termOfValidity;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return credentialList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['credentialName'])) {
            $model->credentialName = $map['credentialName'];
        }
        if (isset($map['credentialType'])) {
            $model->credentialType = $map['credentialType'];
        }
        if (isset($map['termOfValidity'])) {
            $model->termOfValidity = $map['termOfValidity'];
        }

        return $model;
    }
}
