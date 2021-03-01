<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncDataRequest extends Model
{
    /**
     * @var string
     */
    public $projectId;

    /**
     * @var string
     */
    public $schemaId;

    /**
     * @var string
     */
    public $dataId;

    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $etlTime;
    protected $_name = [
        'projectId' => 'projectId',
        'schemaId'  => 'schemaId',
        'dataId'    => 'dataId',
        'content'   => 'content',
        'etlTime'   => 'etlTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
        }
        if (null !== $this->schemaId) {
            $res['schemaId'] = $this->schemaId;
        }
        if (null !== $this->dataId) {
            $res['dataId'] = $this->dataId;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->etlTime) {
            $res['etlTime'] = $this->etlTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }
        if (isset($map['schemaId'])) {
            $model->schemaId = $map['schemaId'];
        }
        if (isset($map['dataId'])) {
            $model->dataId = $map['dataId'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['etlTime'])) {
            $model->etlTime = $map['etlTime'];
        }

        return $model;
    }
}
