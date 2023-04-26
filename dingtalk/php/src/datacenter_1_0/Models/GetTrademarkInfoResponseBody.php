<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTrademarkInfoResponseBody extends Model
{
    /**
     * @example [{ "entName:企业名称", "trademarkName:商标名称", "regNum:商标注册号", "trademarkType:商标类型", "trademarkForm:商标形式", "trademarkStatus:商标状态", "applyDate:申请日期", "imageUrl:图片链接", "typeName:商标类型名", "period:专用权期限", "agent:代理人名称", "regPubNo:注册公告号", "regPubDate:注册公告日期", "firstPubNo:初审公告号", "firstPubDate:初审公告日期"}]
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
     * @return GetTrademarkInfoResponseBody
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
