<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CallMultimodalModelRequest;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CallMultimodalModelRequest\chatMessageModelList\contentList;
use AlibabaCloud\Tea\Model;

class chatMessageModelList extends Model
{
    /**
     * @var contentList[]
     */
    public $contentList;

    /**
     * @example user
     *
     * @var string
     */
    public $role;
    protected $_name = [
        'contentList' => 'contentList',
        'role' => 'role',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentList) {
            $res['contentList'] = [];
            if (null !== $this->contentList && \is_array($this->contentList)) {
                $n = 0;
                foreach ($this->contentList as $item) {
                    $res['contentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return chatMessageModelList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentList'])) {
            if (!empty($map['contentList'])) {
                $model->contentList = [];
                $n = 0;
                foreach ($map['contentList'] as $item) {
                    $model->contentList[$n++] = null !== $item ? contentList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }

        return $model;
    }
}
