<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationAuthorizationServiceConnectorInformationResponseBody\plugInformation;
use AlibabaCloud\Tea\Model;

class ListApplicationAuthorizationServiceConnectorInformationResponseBody extends Model
{
    /**
     * @description 当前第几页
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description pluginInfos
     *
     * @var plugInformation[]
     */
    public $plugInformation;

    /**
     * @description 总数量
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'pageNumber'      => 'pageNumber',
        'pageSize'        => 'pageSize',
        'plugInformation' => 'plugInformation',
        'totalCount'      => 'totalCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->plugInformation) {
            $res['plugInformation'] = [];
            if (null !== $this->plugInformation && \is_array($this->plugInformation)) {
                $n = 0;
                foreach ($this->plugInformation as $item) {
                    $res['plugInformation'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return ListApplicationAuthorizationServiceConnectorInformationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['plugInformation'])) {
            if (!empty($map['plugInformation'])) {
                $model->plugInformation = [];
                $n                      = 0;
                foreach ($map['plugInformation'] as $item) {
                    $model->plugInformation[$n++] = null !== $item ? plugInformation::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
