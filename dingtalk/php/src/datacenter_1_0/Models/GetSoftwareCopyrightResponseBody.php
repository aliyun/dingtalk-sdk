<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSoftwareCopyrightResponseBody extends Model
{
    /**
     * @example [{ "EntName:企业名称", "CopyNum:登记号", "TypeNum:分类号", "ShortName:作品简称", "CopyName:作品全称", "Version:版本号", "SuccessDate:创作完成日期", "FirstDate:首次发表日期", "ApprovalDate:登记批准日期" }]
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
     * @return GetSoftwareCopyrightResponseBody
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
