<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListConnectorInformationResponseBody\pluginInfos;
use AlibabaCloud\Tea\Model;

class ListConnectorInformationResponseBody extends Model
{
    /**
     * @description 分页大小
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 当前第几页
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 总数量
     *
     * @var int
     */
    public $totalCount;

    /**
     * @description pluginInfos
     *
     * @var pluginInfos[]
     */
    public $pluginInfos;
    protected $_name = [
        'pageSize'    => 'pageSize',
        'pageNumber'  => 'pageNumber',
        'totalCount'  => 'totalCount',
        'pluginInfos' => 'pluginInfos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }
        if (null !== $this->pluginInfos) {
            $res['pluginInfos'] = [];
            if (null !== $this->pluginInfos && \is_array($this->pluginInfos)) {
                $n = 0;
                foreach ($this->pluginInfos as $item) {
                    $res['pluginInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListConnectorInformationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }
        if (isset($map['pluginInfos'])) {
            if (!empty($map['pluginInfos'])) {
                $model->pluginInfos = [];
                $n                  = 0;
                foreach ($map['pluginInfos'] as $item) {
                    $model->pluginInfos[$n++] = null !== $item ? pluginInfos::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
