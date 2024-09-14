<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryPersonalMessageReadStatusResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryPersonalMessageReadStatusResponseBody\result\messageReadInfoList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var messageReadInfoList[]
     */
    public $messageReadInfoList;
    protected $_name = [
        'messageReadInfoList' => 'messageReadInfoList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->messageReadInfoList) {
            $res['messageReadInfoList'] = [];
            if (null !== $this->messageReadInfoList && \is_array($this->messageReadInfoList)) {
                $n = 0;
                foreach ($this->messageReadInfoList as $item) {
                    $res['messageReadInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['messageReadInfoList'])) {
            if (!empty($map['messageReadInfoList'])) {
                $model->messageReadInfoList = [];
                $n                          = 0;
                foreach ($map['messageReadInfoList'] as $item) {
                    $model->messageReadInfoList[$n++] = null !== $item ? messageReadInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
