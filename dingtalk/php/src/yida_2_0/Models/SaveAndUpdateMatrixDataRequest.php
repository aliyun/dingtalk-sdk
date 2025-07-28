<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models;

use AlibabaCloud\Tea\Model;

class SaveAndUpdateMatrixDataRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dingxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example [{ 	"column_xx": "deptId", 	"column_yy": ["userId"], 	"column_zz": "项目一", 	"rowId": "row_1748398062718" }, { 	"column_xx": "deptId", 	"column_yy": ["userId", "userId"], 	"column_zz": "项目二" }]
     *
     * @var string
     */
    public $dataJson;

    /**
     * @description This parameter is required.
     *
     * @example MATRIX-C8I4J40EM81XLWZH61ZK
     *
     * @var string
     */
    public $matrixId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $token;

    /**
     * @description This parameter is required.
     *
     * @example 501453
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'corpId' => 'corpId',
        'dataJson' => 'dataJson',
        'matrixId' => 'matrixId',
        'token' => 'token',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->dataJson) {
            $res['dataJson'] = $this->dataJson;
        }
        if (null !== $this->matrixId) {
            $res['matrixId'] = $this->matrixId;
        }
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveAndUpdateMatrixDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['dataJson'])) {
            $model->dataJson = $map['dataJson'];
        }
        if (isset($map['matrixId'])) {
            $model->matrixId = $map['matrixId'];
        }
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
