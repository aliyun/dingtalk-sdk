<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelTaskDataResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelTaskDataResponseBody\content\tags;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var string
     */
    public $deptName;

    /**
     * @var string
     */
    public $deptNo;

    /**
     * @var string
     */
    public $name;

    /**
     * @var tags[]
     */
    public $tags;

    /**
     * @var string
     */
    public $workNo;
    protected $_name = [
        'deptName' => 'deptName',
        'deptNo' => 'deptNo',
        'name' => 'name',
        'tags' => 'tags',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->deptNo) {
            $res['deptNo'] = $this->deptNo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->tags) {
            $res['tags'] = [];
            if (null !== $this->tags && \is_array($this->tags)) {
                $n = 0;
                foreach ($this->tags as $item) {
                    $res['tags'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['deptNo'])) {
            $model->deptNo = $map['deptNo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['tags'])) {
            if (!empty($map['tags'])) {
                $model->tags = [];
                $n = 0;
                foreach ($map['tags'] as $item) {
                    $model->tags[$n++] = null !== $item ? tags::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
