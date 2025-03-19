<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetImportDocumentMarkResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example doc_id
     *
     * @var string
     */
    public $docId;

    /**
     * @example mark_map
     *
     * @var string[]
     */
    public $markMap;
    protected $_name = [
        'docId' => 'docId',
        'markMap' => 'markMap',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->docId) {
            $res['docId'] = $this->docId;
        }
        if (null !== $this->markMap) {
            $res['markMap'] = $this->markMap;
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
        if (isset($map['docId'])) {
            $model->docId = $map['docId'];
        }
        if (isset($map['markMap'])) {
            $model->markMap = $map['markMap'];
        }

        return $model;
    }
}
