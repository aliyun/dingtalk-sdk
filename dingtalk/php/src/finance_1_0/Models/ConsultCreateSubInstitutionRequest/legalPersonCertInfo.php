<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest;

use AlibabaCloud\Tea\Model;

class legalPersonCertInfo extends Model
{
    /**
     * @example ossUrl
     *
     * @var string
     */
    public $certBackImage;

    /**
     * @example ossUrl
     *
     * @var string
     */
    public $certFrontImage;

    /**
     * @example 李某某
     *
     * @var string
     */
    public $certName;

    /**
     * @example 100
     *
     * @var string
     */
    public $certType;

    /**
     * @example 330104200010109999
     *
     * @var string
     */
    public $idCardNo;
    protected $_name = [
        'certBackImage'  => 'certBackImage',
        'certFrontImage' => 'certFrontImage',
        'certName'       => 'certName',
        'certType'       => 'certType',
        'idCardNo'       => 'idCardNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->certBackImage) {
            $res['certBackImage'] = $this->certBackImage;
        }
        if (null !== $this->certFrontImage) {
            $res['certFrontImage'] = $this->certFrontImage;
        }
        if (null !== $this->certName) {
            $res['certName'] = $this->certName;
        }
        if (null !== $this->certType) {
            $res['certType'] = $this->certType;
        }
        if (null !== $this->idCardNo) {
            $res['idCardNo'] = $this->idCardNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return legalPersonCertInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['certBackImage'])) {
            $model->certBackImage = $map['certBackImage'];
        }
        if (isset($map['certFrontImage'])) {
            $model->certFrontImage = $map['certFrontImage'];
        }
        if (isset($map['certName'])) {
            $model->certName = $map['certName'];
        }
        if (isset($map['certType'])) {
            $model->certType = $map['certType'];
        }
        if (isset($map['idCardNo'])) {
            $model->idCardNo = $map['idCardNo'];
        }

        return $model;
    }
}
