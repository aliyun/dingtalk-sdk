<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest;

use AlibabaCloud\Tea\Model;

class legalPersonCertInfo extends Model
{
    /**
     * @description 法人姓名
     *
     * @var string
     */
    public $certName;

    /**
     * @description 法人证件号
     *
     * @var string
     */
    public $idCardNo;

    /**
     * @description 法人证件正面url
     *
     * @var string
     */
    public $certFrontImage;

    /**
     * @description 法人证件反面url
     *
     * @var string
     */
    public $certBackImage;

    /**
     * @description 法人证件类型 不填默认为身份证
     *
     * @var string
     */
    public $certType;
    protected $_name = [
        'certName'       => 'certName',
        'idCardNo'       => 'idCardNo',
        'certFrontImage' => 'certFrontImage',
        'certBackImage'  => 'certBackImage',
        'certType'       => 'certType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->certName) {
            $res['certName'] = $this->certName;
        }
        if (null !== $this->idCardNo) {
            $res['idCardNo'] = $this->idCardNo;
        }
        if (null !== $this->certFrontImage) {
            $res['certFrontImage'] = $this->certFrontImage;
        }
        if (null !== $this->certBackImage) {
            $res['certBackImage'] = $this->certBackImage;
        }
        if (null !== $this->certType) {
            $res['certType'] = $this->certType;
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
        if (isset($map['certName'])) {
            $model->certName = $map['certName'];
        }
        if (isset($map['idCardNo'])) {
            $model->idCardNo = $map['idCardNo'];
        }
        if (isset($map['certFrontImage'])) {
            $model->certFrontImage = $map['certFrontImage'];
        }
        if (isset($map['certBackImage'])) {
            $model->certBackImage = $map['certBackImage'];
        }
        if (isset($map['certType'])) {
            $model->certType = $map['certType'];
        }

        return $model;
    }
}
