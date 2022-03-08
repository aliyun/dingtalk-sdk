<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteKnowledgeRequest extends Model
{
    /**
     * @description 知识库的唯一标识 比如:天工知识库ID
     *
     * @var string
     */
    public $libraryKey;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 知识点来源 CCM:天工知识库
     *
     * @var string
     */
    public $source;

    /**
     * @description 知识点唯一标识
     *
     * @var string
     */
    public $sourcePrimaryKey;
    protected $_name = [
        'libraryKey'       => 'libraryKey',
        'openTeamId'       => 'openTeamId',
        'source'           => 'source',
        'sourcePrimaryKey' => 'sourcePrimaryKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->libraryKey) {
            $res['libraryKey'] = $this->libraryKey;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->sourcePrimaryKey) {
            $res['sourcePrimaryKey'] = $this->sourcePrimaryKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteKnowledgeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['libraryKey'])) {
            $model->libraryKey = $map['libraryKey'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['sourcePrimaryKey'])) {
            $model->sourcePrimaryKey = $map['sourcePrimaryKey'];
        }

        return $model;
    }
}
