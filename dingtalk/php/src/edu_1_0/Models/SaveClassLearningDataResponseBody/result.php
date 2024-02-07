<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SaveClassLearningDataResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string[]
     */
    public $questionUploadUrlList;

    /**
     * @var string[]
     */
    public $standardAnswerUploadUrlList;
    protected $_name = [
        'questionUploadUrlList'       => 'questionUploadUrlList',
        'standardAnswerUploadUrlList' => 'standardAnswerUploadUrlList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->questionUploadUrlList) {
            $res['questionUploadUrlList'] = $this->questionUploadUrlList;
        }
        if (null !== $this->standardAnswerUploadUrlList) {
            $res['standardAnswerUploadUrlList'] = $this->standardAnswerUploadUrlList;
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
        if (isset($map['questionUploadUrlList'])) {
            if (!empty($map['questionUploadUrlList'])) {
                $model->questionUploadUrlList = $map['questionUploadUrlList'];
            }
        }
        if (isset($map['standardAnswerUploadUrlList'])) {
            if (!empty($map['standardAnswerUploadUrlList'])) {
                $model->standardAnswerUploadUrlList = $map['standardAnswerUploadUrlList'];
            }
        }

        return $model;
    }
}
