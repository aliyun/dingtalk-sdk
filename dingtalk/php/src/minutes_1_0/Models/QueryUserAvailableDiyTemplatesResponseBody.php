<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUserAvailableDiyTemplatesResponseBody\orgDiyTemplates;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUserAvailableDiyTemplatesResponseBody\userDiyTemplates;
use AlibabaCloud\Tea\Model;

class QueryUserAvailableDiyTemplatesResponseBody extends Model
{
    /**
     * @var bool
     */
    public $hasNext;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var orgDiyTemplates[]
     */
    public $orgDiyTemplates;

    /**
     * @var userDiyTemplates[]
     */
    public $userDiyTemplates;
    protected $_name = [
        'hasNext' => 'hasNext',
        'nextToken' => 'nextToken',
        'orgDiyTemplates' => 'orgDiyTemplates',
        'userDiyTemplates' => 'userDiyTemplates',
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
        if (null !== $this->orgDiyTemplates) {
            $res['orgDiyTemplates'] = [];
            if (null !== $this->orgDiyTemplates && \is_array($this->orgDiyTemplates)) {
                $n = 0;
                foreach ($this->orgDiyTemplates as $item) {
                    $res['orgDiyTemplates'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userDiyTemplates) {
            $res['userDiyTemplates'] = [];
            if (null !== $this->userDiyTemplates && \is_array($this->userDiyTemplates)) {
                $n = 0;
                foreach ($this->userDiyTemplates as $item) {
                    $res['userDiyTemplates'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserAvailableDiyTemplatesResponseBody
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
        if (isset($map['orgDiyTemplates'])) {
            if (!empty($map['orgDiyTemplates'])) {
                $model->orgDiyTemplates = [];
                $n = 0;
                foreach ($map['orgDiyTemplates'] as $item) {
                    $model->orgDiyTemplates[$n++] = null !== $item ? orgDiyTemplates::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userDiyTemplates'])) {
            if (!empty($map['userDiyTemplates'])) {
                $model->userDiyTemplates = [];
                $n = 0;
                foreach ($map['userDiyTemplates'] as $item) {
                    $model->userDiyTemplates[$n++] = null !== $item ? userDiyTemplates::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
