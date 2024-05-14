<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySchoolUserFaceResponseBody\userFaceList;
use AlibabaCloud\Tea\Model;

class QuerySchoolUserFaceResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dingding123
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example true/false
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description This parameter is required.
     *
     * @var userFaceList[]
     */
    public $userFaceList;
    protected $_name = [
        'corpId'       => 'corpId',
        'hasMore'      => 'hasMore',
        'userFaceList' => 'userFaceList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->userFaceList) {
            $res['userFaceList'] = [];
            if (null !== $this->userFaceList && \is_array($this->userFaceList)) {
                $n = 0;
                foreach ($this->userFaceList as $item) {
                    $res['userFaceList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySchoolUserFaceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['userFaceList'])) {
            if (!empty($map['userFaceList'])) {
                $model->userFaceList = [];
                $n                   = 0;
                foreach ($map['userFaceList'] as $item) {
                    $model->userFaceList[$n++] = null !== $item ? userFaceList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
