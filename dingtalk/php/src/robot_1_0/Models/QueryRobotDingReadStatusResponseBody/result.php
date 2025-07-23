<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\QueryRobotDingReadStatusResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\QueryRobotDingReadStatusResponseBody\result\robotDingReadInfoList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var robotDingReadInfoList[]
     */
    public $robotDingReadInfoList;
    protected $_name = [
        'robotDingReadInfoList' => 'robotDingReadInfoList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->robotDingReadInfoList) {
            $res['robotDingReadInfoList'] = [];
            if (null !== $this->robotDingReadInfoList && \is_array($this->robotDingReadInfoList)) {
                $n = 0;
                foreach ($this->robotDingReadInfoList as $item) {
                    $res['robotDingReadInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['robotDingReadInfoList'])) {
            if (!empty($map['robotDingReadInfoList'])) {
                $model->robotDingReadInfoList = [];
                $n = 0;
                foreach ($map['robotDingReadInfoList'] as $item) {
                    $model->robotDingReadInfoList[$n++] = null !== $item ? robotDingReadInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
