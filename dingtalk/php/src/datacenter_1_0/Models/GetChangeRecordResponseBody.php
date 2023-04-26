<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetChangeRecordResponseBody extends Model
{
    /**
     * @example [         {             "Type":"投资人变更(包括出资额、出资方式、出资日期、投资人名称等)",             "ChangeDate":"2014-12-23",             "AfterContent":"股东名称:华为投资控股有限公司、出资额:3990813.182000、出资比例:100.000000;",             "BeforeContent":"股东名称:华为投资控股有限公司、出资额:3960813.182000、出资比例:100.000000;"         },         {             "Type":"期限变更(经营期限、营业期限、驻在期限、合伙期限等变更)",             "ChangeDate":"1997-12-04",             "AfterContent":"1987-09-15,2040-04-09",             "BeforeContent":"1987-09-15,1998-12-31"         } ]
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
     * @return GetChangeRecordResponseBody
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
