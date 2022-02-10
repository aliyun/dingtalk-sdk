<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduTeacherListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduTeacherListResponseBody\result\teacherDetails;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 是否还有下一页
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 教师信息
     *
     * @var teacherDetails[]
     */
    public $teacherDetails;
    protected $_name = [
        'hasMore'        => 'hasMore',
        'teacherDetails' => 'teacherDetails',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->teacherDetails) {
            $res['teacherDetails'] = [];
            if (null !== $this->teacherDetails && \is_array($this->teacherDetails)) {
                $n = 0;
                foreach ($this->teacherDetails as $item) {
                    $res['teacherDetails'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['teacherDetails'])) {
            if (!empty($map['teacherDetails'])) {
                $model->teacherDetails = [];
                $n                     = 0;
                foreach ($map['teacherDetails'] as $item) {
                    $model->teacherDetails[$n++] = null !== $item ? teacherDetails::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
