<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenSearchGroupListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenSearchGroupListResponseBody\result\groupList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var groupList[]
     */
    public $groupList;
    protected $_name = [
        'groupList' => 'groupList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupList) {
            $res['groupList'] = [];
            if (null !== $this->groupList && \is_array($this->groupList)) {
                $n = 0;
                foreach ($this->groupList as $item) {
                    $res['groupList'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['groupList'])) {
            if (!empty($map['groupList'])) {
                $model->groupList = [];
                $n                = 0;
                foreach ($map['groupList'] as $item) {
                    $model->groupList[$n++] = null !== $item ? groupList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
