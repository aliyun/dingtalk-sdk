<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateSubInstitutionRequest;

use AlibabaCloud\Tea\Model;

class subInstCertifyInfo extends Model
{
    /**
     * @description 证件图片, 如果是特殊行业必填
     *
     * @var string
     */
    public $certImage;

    /**
     * @description 证件号码
     *
     * @var string
     */
    public $certNo;

    /**
     * @description 证件类型
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
