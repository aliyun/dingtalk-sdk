<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListConvNavTabResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListConvNavTabResponseBody\result\convNavTabInfos;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var convNavTabInfos[]
     */
    public $convNavTabInfos;
    protected $_name = [
        'convNavTabInfos' => 'convNavTabInfos',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->convNavTabInfos) {
            $res['convNavTabInfos'] = [];
            if (null !== $this->convNavTabInfos && \is_array($this->convNavTabInfos)) {
                $n = 0;
                foreach ($this->convNavTabInfos as $item) {
                    $res['convNavTabInfos'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['convNavTabInfos'])) {
            if (!empty($map['convNavTabInfos'])) {
                $model->convNavTabInfos = [];
                $n = 0;
                foreach ($map['convNavTabInfos'] as $item) {
                    $model->convNavTabInfos[$n++] = null !== $item ? convNavTabInfos::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
