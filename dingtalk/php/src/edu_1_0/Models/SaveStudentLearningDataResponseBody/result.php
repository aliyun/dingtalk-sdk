<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SaveStudentLearningDataResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SaveStudentLearningDataResponseBody\result\wrongQuestions;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $saveSuccess;

    /**
     * @var wrongQuestions[]
     */
    public $wrongQuestions;
    protected $_name = [
        'saveSuccess' => 'saveSuccess',
        'wrongQuestions' => 'wrongQuestions',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->saveSuccess) {
            $res['saveSuccess'] = $this->saveSuccess;
        }
        if (null !== $this->wrongQuestions) {
            $res['wrongQuestions'] = [];
            if (null !== $this->wrongQuestions && \is_array($this->wrongQuestions)) {
                $n = 0;
                foreach ($this->wrongQuestions as $item) {
                    $res['wrongQuestions'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['saveSuccess'])) {
            $model->saveSuccess = $map['saveSuccess'];
        }
        if (isset($map['wrongQuestions'])) {
            if (!empty($map['wrongQuestions'])) {
                $model->wrongQuestions = [];
                $n = 0;
                foreach ($map['wrongQuestions'] as $item) {
                    $model->wrongQuestions[$n++] = null !== $item ? wrongQuestions::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
