<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublisherSummaryResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 历史截至当日服务窗文章数
     *
     * @var string
     */
    public $publisherArticleCntStd;

    /**
     * @description 历史截至当日服务窗文章阅读数
     *
     * @var string
     */
    public $publisherArticlePvCntStd;

    /**
     * @description 服务窗名称
     *
     * @var string
     */
    public $publisherName;

    /**
     * @description 服务窗unionId
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'publisherArticleCntStd'   => 'publisherArticleCntStd',
        'publisherArticlePvCntStd' => 'publisherArticlePvCntStd',
        'publisherName'            => 'publisherName',
        'unionId'                  => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->publisherArticleCntStd) {
            $res['publisherArticleCntStd'] = $this->publisherArticleCntStd;
        }
        if (null !== $this->publisherArticlePvCntStd) {
            $res['publisherArticlePvCntStd'] = $this->publisherArticlePvCntStd;
        }
        if (null !== $this->publisherName) {
            $res['publisherName'] = $this->publisherName;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['publisherArticleCntStd'])) {
            $model->publisherArticleCntStd = $map['publisherArticleCntStd'];
        }
        if (isset($map['publisherArticlePvCntStd'])) {
            $model->publisherArticlePvCntStd = $map['publisherArticlePvCntStd'];
        }
        if (isset($map['publisherName'])) {
            $model->publisherName = $map['publisherName'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
