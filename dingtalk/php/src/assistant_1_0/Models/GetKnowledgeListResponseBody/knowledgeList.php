<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetKnowledgeListResponseBody;

use AlibabaCloud\Tea\Model;

class knowledgeList extends Model
{
    /**
     * @var string
     */
    public $docFormat;

    /**
     * @var string
     */
    public $docName;

    /**
     * @var string
     */
    public $docUrl;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $studyId;
    protected $_name = [
        'docFormat' => 'docFormat',
        'docName'   => 'docName',
        'docUrl'    => 'docUrl',
        'status'    => 'status',
        'studyId'   => 'studyId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->docFormat) {
            $res['docFormat'] = $this->docFormat;
        }
        if (null !== $this->docName) {
            $res['docName'] = $this->docName;
        }
        if (null !== $this->docUrl) {
            $res['docUrl'] = $this->docUrl;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->studyId) {
            $res['studyId'] = $this->studyId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return knowledgeList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['docFormat'])) {
            $model->docFormat = $map['docFormat'];
        }
        if (isset($map['docName'])) {
            $model->docName = $map['docName'];
        }
        if (isset($map['docUrl'])) {
            $model->docUrl = $map['docUrl'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['studyId'])) {
            $model->studyId = $map['studyId'];
        }

        return $model;
    }
}
