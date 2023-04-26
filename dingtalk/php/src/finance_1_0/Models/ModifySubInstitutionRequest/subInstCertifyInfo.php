<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest;

use AlibabaCloud\Tea\Model;

class subInstCertifyInfo extends Model
{
    /**
     * @example ossUrl
     *
     * @var string
     */
    public $certImage;

    /**
     * @example 331081198611111111
     *
     * @var string
     */
    public $certNo;

    /**
     * @example 201
     *
     * @var string
     */
    public $certType;
    protected $_name = [
        'certImage' => 'certImage',
        'certNo'    => 'certNo',
        'certType'  => 'certType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->certImage) {
            $res['certImage'] = $this->certImage;
        }
        if (null !== $this->certNo) {
            $res['certNo'] = $this->certNo;
        }
        if (null !== $this->certType) {
            $res['certType'] = $this->certType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subInstCertifyInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['certImage'])) {
            $model->certImage = $map['certImage'];
        }
        if (isset($map['certNo'])) {
            $model->certNo = $map['certNo'];
        }
        if (isset($map['certType'])) {
            $model->certType = $map['certType'];
        }

        return $model;
    }
}
