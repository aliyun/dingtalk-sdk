<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetBiddingInfoResponseBody extends Model
{
    /**
     * @example [{ "EntName":"企业名称", "BidTitle":"标文标题", "BidType":"招标方式", "RegionName":"地区", "BidIndustry":"标的所属行业", "PublicDate":"发布时间", "ProjectNum":"项目编号", "ProjectName":"项目名称", "ProjectAmount":"项目金额", "TenderEntName":"招标企业", "AgentEntName":"代理企业", "WinnerEntName":"中标企业", "Content":"正文", "InfoType":"标文类型", "SubType":"子类型", "OpeningTime":"开标时间" }]
     *
     * @var string
     */
    public $data;

    /**
     * @var int
     */
    public $total;
    protected $_name = [
        'data' => 'data',
        'total' => 'total',
    ];

    public function validate() {}

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
     * @return GetBiddingInfoResponseBody
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
