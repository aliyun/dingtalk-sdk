<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetSolutionConfigResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetSolutionConfigResponseBody\result\dialectList;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetSolutionConfigResponseBody\result\solutionList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var dialectList[]
     */
    public $dialectList;

    /**
     * @var solutionList[]
     */
    public $solutionList;
    protected $_name = [
        'dialectList' => 'dialectList',
        'solutionList' => 'solutionList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dialectList) {
            $res['dialectList'] = [];
            if (null !== $this->dialectList && \is_array($this->dialectList)) {
                $n = 0;
                foreach ($this->dialectList as $item) {
                    $res['dialectList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->solutionList) {
            $res['solutionList'] = [];
            if (null !== $this->solutionList && \is_array($this->solutionList)) {
                $n = 0;
                foreach ($this->solutionList as $item) {
                    $res['solutionList'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['dialectList'])) {
            if (!empty($map['dialectList'])) {
                $model->dialectList = [];
                $n = 0;
                foreach ($map['dialectList'] as $item) {
                    $model->dialectList[$n++] = null !== $item ? dialectList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['solutionList'])) {
            if (!empty($map['solutionList'])) {
                $model->solutionList = [];
                $n = 0;
                foreach ($map['solutionList'] as $item) {
                    $model->solutionList[$n++] = null !== $item ? solutionList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
