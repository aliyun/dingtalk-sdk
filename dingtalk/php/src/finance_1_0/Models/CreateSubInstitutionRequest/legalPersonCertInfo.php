<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateSubInstitutionRequest;

use AlibabaCloud\Tea\Model;

class legalPersonCertInfo extends Model
{
    /**
     * @description 法人证件反面url
     *
     * @var string
     */
    public $certBackImage;

    /**
     * @description 法人证件正面url
     *
     * @var string
     */
    public $certFrontImage;

    /**
     * @description 法人姓名
     *
     * @var string
     */
    public $certName;

    /**
     * @description 法人证件类型 不填默认为身份证
     *
     * @var string
     */
    public $certType;

    /**
     * @description 法人证件号
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
