<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetQualificationCertResponseBody extends Model
{
    /**
     * @example [{"EntName":"企业名称", "CertType":"证书类型", "CertNum":"证书认证编号", "ValidStartDate":"有效期开始日期", "ValidEndDate":"有效期截止日期", "AuthorizeDate":"授权日期", "AuthorizeDepartment":"授权部门", "PubDate":"公示日期", "Province":"省份", "CertScope":"认证范围"} ]
     *
     * @var string
     */
    public $data;

    /**
     * @var int
     */
    public $total;
    protected $_name = [
        'data'  => 'data',
        'total' => 'total',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetQualificationCertResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
