<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetSecurityConfigMemberResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetSecurityConfigMemberResponseBody\result\userInfos;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $hasNext;

    /**
     * @var float
     */
    public $nextToken;

    /**
     * @var int
     */
    public $scopeType;

    /**
     * @var userInfos[]
     */
    public $userInfos;
    protected $_name = [
        'hasNext' => 'hasNext',
        'nextToken' => 'nextToken',
        'scopeType' => 'scopeType',
        'userInfos' => 'userInfos',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasNext) {
            $res['hasNext'] = $this->hasNext;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->scopeType) {
            $res['scopeType'] = $this->scopeType;
        }
        if (null !== $this->userInfos) {
            $res['userInfos'] = [];
            if (null !== $this->userInfos && \is_array($this->userInfos)) {
                $n = 0;
                foreach ($this->userInfos as $item) {
                    $res['userInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasNext'])) {
            $model->hasNext = $map['hasNext'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['scopeType'])) {
            $model->scopeType = $map['scopeType'];
        }
        if (isset($map['userInfos'])) {
            if (!empty($map['userInfos'])) {
                $model->userInfos = [];
                $n = 0;
                foreach ($map['userInfos'] as $item) {
                    $model->userInfos[$n++] = null !== $item ? userInfos::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
