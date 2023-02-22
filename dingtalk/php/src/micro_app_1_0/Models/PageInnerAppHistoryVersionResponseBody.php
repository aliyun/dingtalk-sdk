<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\PageInnerAppHistoryVersionResponseBody\miniAppVersionList;
use AlibabaCloud\Tea\Model;

class PageInnerAppHistoryVersionResponseBody extends Model
{
    /**
     * @description 企业内部小程序版本号列表
     *
     * @var miniAppVersionList[]
     */
    public $miniAppVersionList;

    /**
     * @description 当前小程序历史版本的总数量
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'miniAppVersionList' => 'miniAppVersionList',
        'totalCount'         => 'totalCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->miniAppVersionList) {
            $res['miniAppVersionList'] = [];
            if (null !== $this->miniAppVersionList && \is_array($this->miniAppVersionList)) {
                $n = 0;
                foreach ($this->miniAppVersionList as $item) {
                    $res['miniAppVersionList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PageInnerAppHistoryVersionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['miniAppVersionList'])) {
            if (!empty($map['miniAppVersionList'])) {
                $model->miniAppVersionList = [];
                $n                         = 0;
                foreach ($map['miniAppVersionList'] as $item) {
                    $model->miniAppVersionList[$n++] = null !== $item ? miniAppVersionList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
