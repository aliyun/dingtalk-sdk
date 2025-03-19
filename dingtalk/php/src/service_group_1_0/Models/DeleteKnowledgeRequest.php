<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteKnowledgeRequest extends Model
{
    /**
     * @example xuvw1245
     *
     * @var string
     */
    public $libraryKey;

    /**
     * @example Js1i0w3k
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @example CCM
     *
     * @var string
     */
    public $source;

    /**
     * @example CCM-123
     *
     * @var string
     */
    public $sourcePrimaryKey;
    protected $_name = [
        'libraryKey' => 'libraryKey',
        'openTeamId' => 'openTeamId',
        'source' => 'source',
        'sourcePrimaryKey' => 'sourcePrimaryKey',
    ];

    public function validate() {}

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
