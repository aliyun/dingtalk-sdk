<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetSignedDetailByPageResponseBody\auditSignedDetailDTOList;
use AlibabaCloud\Tea\Model;

class GetSignedDetailByPageResponseBody extends Model
{
    /**
     * @var auditSignedDetailDTOList[]
     */
    public $auditSignedDetailDTOList;

    /**
     * @example 1
     *
     * @var int
     */
    public $currentPage;

    /**
     * @example 50
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 1000
     *
     * @var int
     */
    public $total;
    protected $_name = [
        'auditSignedDetailDTOList' => 'auditSignedDetailDTOList',
        'currentPage'              => 'currentPage',
        'pageSize'                 => 'pageSize',
        'total'                    => 'total',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->auditSignedDetailDTOList) {
            $res['auditSignedDetailDTOList'] = [];
            if (null !== $this->auditSignedDetailDTOList && \is_array($this->auditSignedDetailDTOList)) {
                $n = 0;
                foreach ($this->auditSignedDetailDTOList as $item) {
                    $res['auditSignedDetailDTOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->currentPage) {
            $res['currentPage'] = $this->currentPage;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSignedDetailByPageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['auditSignedDetailDTOList'])) {
            if (!empty($map['auditSignedDetailDTOList'])) {
                $model->auditSignedDetailDTOList = [];
                $n                               = 0;
                foreach ($map['auditSignedDetailDTOList'] as $item) {
                    $model->auditSignedDetailDTOList[$n++] = null !== $item ? auditSignedDetailDTOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['currentPage'])) {
            $model->currentPage = $map['currentPage'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
