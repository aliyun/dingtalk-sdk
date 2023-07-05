<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class InitDocumentRequest extends Model
{
    /**
     * @example attachments_map
     *
     * @var AttachmentsMapValue[]
     */
    public $attachmentsMap;

    /**
     * @example import_type
     *
     * @var int
     */
    public $importType;

    /**
     * @example links_key
     *
     * @var string
     */
    public $linksKey;

    /**
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'attachmentsMap' => 'attachmentsMap',
        'importType'     => 'importType',
        'linksKey'       => 'linksKey',
        'operatorId'     => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachmentsMap) {
            $res['attachmentsMap'] = [];
            if (null !== $this->attachmentsMap && \is_array($this->attachmentsMap)) {
                foreach ($this->attachmentsMap as $key => $val) {
                    $res['attachmentsMap'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->importType) {
            $res['importType'] = $this->importType;
        }
        if (null !== $this->linksKey) {
            $res['linksKey'] = $this->linksKey;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InitDocumentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachmentsMap'])) {
            $model->attachmentsMap = $map['attachmentsMap'];
        }
        if (isset($map['importType'])) {
            $model->importType = $map['importType'];
        }
        if (isset($map['linksKey'])) {
            $model->linksKey = $map['linksKey'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
