<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationAuthorizationServiceApplicationInformationResponseBody\applicationInformation;
use AlibabaCloud\Tea\Model;

class ListApplicationAuthorizationServiceApplicationInformationResponseBody extends Model
{
    /**
     * @var applicationInformation[]
     */
    public $applicationInformation;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 100
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 100
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'applicationInformation' => 'applicationInformation',
        'pageNumber'             => 'pageNumber',
        'pageSize'               => 'pageSize',
        'totalCount'             => 'totalCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->applicationInformation) {
            $res['applicationInformation'] = [];
            if (null !== $this->applicationInformation && \is_array($this->applicationInformation)) {
                $n = 0;
                foreach ($this->applicationInformation as $item) {
                    $res['applicationInformation'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListApplicationAuthorizationServiceApplicationInformationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['applicationInformation'])) {
            if (!empty($map['applicationInformation'])) {
                $model->applicationInformation = [];
                $n                             = 0;
                foreach ($map['applicationInformation'] as $item) {
                    $model->applicationInformation[$n++] = null !== $item ? applicationInformation::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
