<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendRequest\candidateOkrItems;
use AlibabaCloud\Tea\Model;

class OkrOpenRecommendRequest extends Model
{
    /**
     * @var candidateOkrItems[]
     */
    public $candidateOkrItems;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string[]
     */
    public $deptIds;

    /**
     * @var string
     */
    public $isvAppId;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string[]
     */
    public $words;
    protected $_name = [
        'candidateOkrItems' => 'candidateOkrItems',
        'corpId'            => 'corpId',
        'deptIds'           => 'deptIds',
        'isvAppId'          => 'isvAppId',
        'userId'            => 'userId',
        'words'             => 'words',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->candidateOkrItems) {
            $res['candidateOkrItems'] = [];
            if (null !== $this->candidateOkrItems && \is_array($this->candidateOkrItems)) {
                $n = 0;
                foreach ($this->candidateOkrItems as $item) {
                    $res['candidateOkrItems'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->isvAppId) {
            $res['isvAppId'] = $this->isvAppId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->words) {
            $res['words'] = $this->words;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OkrOpenRecommendRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['candidateOkrItems'])) {
            if (!empty($map['candidateOkrItems'])) {
                $model->candidateOkrItems = [];
                $n                        = 0;
                foreach ($map['candidateOkrItems'] as $item) {
                    $model->candidateOkrItems[$n++] = null !== $item ? candidateOkrItems::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['isvAppId'])) {
            $model->isvAppId = $map['isvAppId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['words'])) {
            if (!empty($map['words'])) {
                $model->words = $map['words'];
            }
        }

        return $model;
    }
}
