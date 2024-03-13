<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryPermissionByUserIdResponseBody\permissionDTOList;
use AlibabaCloud\Tea\Model;

class QueryPermissionByUserIdResponseBody extends Model
{
    /**
     * @var string
     */
    public $companyCode;

    /**
     * @var permissionDTOList[]
     */
    public $permissionDTOList;

    /**
     * @example 123456789
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'companyCode'       => 'companyCode',
        'permissionDTOList' => 'permissionDTOList',
        'userId'            => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->permissionDTOList) {
            $res['permissionDTOList'] = [];
            if (null !== $this->permissionDTOList && \is_array($this->permissionDTOList)) {
                $n = 0;
                foreach ($this->permissionDTOList as $item) {
                    $res['permissionDTOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPermissionByUserIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['permissionDTOList'])) {
            if (!empty($map['permissionDTOList'])) {
                $model->permissionDTOList = [];
                $n                        = 0;
                foreach ($map['permissionDTOList'] as $item) {
                    $model->permissionDTOList[$n++] = null !== $item ? permissionDTOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
