<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcredit_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryScoreRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example MD5
     *
     * @var string
     */
    public $encryption;

    /**
     * @example a0fbf479272cd38c220fbf726678d8d6
     *
     * @var string
     */
    public $fullName;

    /**
     * @example b04a604cf00e64136b386e83444245c3
     *
     * @var string
     */
    public $idCardCode;

    /**
     * @description This parameter is required.
     *
     * @example e10adc3949ba59abbe56e057f20f883e
     *
     * @var string
     */
    public $mobile;

    /**
     * @example aca03c931768ea4b0244531aca9a19ee
     *
     * @var string
     */
    public $orgName;

    /**
     * @example a57d7bf49b6e44180b21b1fea80eec0a
     *
     * @var string
     */
    public $uniScCode;
    protected $_name = [
        'encryption' => 'encryption',
        'fullName' => 'fullName',
        'idCardCode' => 'idCardCode',
        'mobile' => 'mobile',
        'orgName' => 'orgName',
        'uniScCode' => 'uniScCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->encryption) {
            $res['encryption'] = $this->encryption;
        }
        if (null !== $this->fullName) {
            $res['fullName'] = $this->fullName;
        }
        if (null !== $this->idCardCode) {
            $res['idCardCode'] = $this->idCardCode;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }
        if (null !== $this->uniScCode) {
            $res['uniScCode'] = $this->uniScCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryScoreRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['encryption'])) {
            $model->encryption = $map['encryption'];
        }
        if (isset($map['fullName'])) {
            $model->fullName = $map['fullName'];
        }
        if (isset($map['idCardCode'])) {
            $model->idCardCode = $map['idCardCode'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }
        if (isset($map['uniScCode'])) {
            $model->uniScCode = $map['uniScCode'];
        }

        return $model;
    }
}
